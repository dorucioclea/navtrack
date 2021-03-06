using System;
using Navtrack.Library.DI;
using Navtrack.Listener.Helpers;
using Navtrack.Listener.Models;
using Navtrack.Listener.Server;

namespace Navtrack.Listener.Protocols.Neomatica
{
    [Service(typeof(ICustomMessageHandler<NeomaticaProtocol>))]
    public class NeomaticaMessageHandler : BaseMessageHandler<NeomaticaProtocol>
    {
        public override Location Parse(MessageInput input)
        {
            input.DataMessage.ByteReader.Get<short>(); // device id

            int size = input.DataMessage.ByteReader.GetOne();
            int type = input.DataMessage.ByteReader.GetOne();

            if (type == 0x03) // imei
            {
                input.Client.SetDevice(StringUtil.ConvertByteArrayToString(input.DataMessage.ByteReader.Get(15)));
            }
            else
            {
                return GetLocation(input, type);
            }

            return null;
        }


        private static Location GetLocation(MessageInput input, int type)
        {
            if (input.Client.Device == null)
            {
                return null;
            }

            Location location = new Location
            {
                Device = input.Client.Device
            };

            input.DataMessage.ByteReader.GetOne();
            input.DataMessage.ByteReader.Get<short>();

            short status = input.DataMessage.ByteReader.Get<short>();
            location.PositionStatus = !BitUtil.IsTrue(status, 5);
            location.Latitude = (decimal) input.DataMessage.ByteReader.Get<float>();
            location.Longitude = (decimal) input.DataMessage.ByteReader.Get<float>();
            location.Heading = input.DataMessage.ByteReader.Get<short>() * 0.1m;
            location.Speed = input.DataMessage.ByteReader.Get<short>() * 0.1m;
            input.DataMessage.ByteReader.GetOne();
            location.Altitude = input.DataMessage.ByteReader.Get<short>();
            location.HDOP = input.DataMessage.ByteReader.GetOne() * 0.1m;
            location.Satellites = (short?) (input.DataMessage.ByteReader.GetOne() & 0x0f);
            location.DateTime = DateTime.UnixEpoch.AddSeconds(input.DataMessage.ByteReader.Get<int>());

            MarkAsNull(location);

            return location;
        }

        private static void MarkAsNull(Location location)
        {
            if (!location.PositionStatus.GetValueOrDefault())
            {
                location.Heading = null;
                location.Speed = null;
                location.Altitude = null;
                location.HDOP = null;
                location.Satellites = null;
            }
        }
    }
}