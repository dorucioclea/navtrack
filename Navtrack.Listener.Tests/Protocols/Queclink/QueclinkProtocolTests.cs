using Navtrack.Listener.Protocols.Queclink;
using NUnit.Framework;

namespace Navtrack.Listener.Tests.Protocols.Queclink
{
    public class QueclinkProtocolTests : BaseProtocolTests<QueclinkProtocol, QueclinkMessageHandler>
    {
        [Test]
        public void DeviceSendsLocationV1_ParsedLocationIsNotNull()
        {
            ProtocolTester.SendStringFromDevice("+RESP:GTMON,060100,135790246811220,,+8613812341234,15,0,0,4.3,92,70.0,121.354335,31.222073,20090214013254,0460,0000,18d8,6141,00,20090214093254,11F0$");

            Assert.IsNotNull(ProtocolTester.LastParsedLocation);
        }
        
        [Test]
        public void DeviceSendsLocationV2_ParsedLocationIsNotNull()
        {
            ProtocolTester.SendStringFromDevice("+RESP:GTMPN,060100,135790246811220,,0,4.3,92,70.0,121.354335,31.222073,20090214013254,0460,0000,18d8,6141,00,20090214093254,11F0$");

            Assert.IsNotNull(ProtocolTester.LastParsedLocation);
        }
        
        [Test]
        public void DeviceSendsLocationV3_ParsedLocationIsNotNull()
        {
            ProtocolTester.SendStringFromDevice("+RESP:GTBTC,060100,135790246811220,,0,4.3,92,70.0,121.354335,31.222073,20090214013254,0460,0000,18d8,6141,00,20090214093254,11F0$");

            Assert.IsNotNull(ProtocolTester.LastParsedLocation);
        }
        
        [Test]
        public void DeviceSendsLocationV4_ParsedLocationIsNotNull()
        {
            ProtocolTester.SendStringFromDevice("+RESP:GTSPD,020102,135790246811220,,0,0,1,1,4.3,92,70.0,121.354335,31.222073,20090214013254,0460,0000,18d8,6141,00,,20090214093254,11F0$");

            Assert.IsNotNull(ProtocolTester.LastParsedLocation);
        }
        
        [Test]
        public void DeviceSendsLocationV5_ParsedLocationIsNotNull()
        {
            ProtocolTester.SendStringFromDevice("+RESP:GTRTL,020102,135790246811220,,0,0,1,1,4.3,92,70.0,121.354335,31.222073,20090214013254,0460,0000,18d8,6141,00,,20090214093254,11F0$");

            Assert.IsNotNull(ProtocolTester.LastParsedLocation);
        }
    }
}