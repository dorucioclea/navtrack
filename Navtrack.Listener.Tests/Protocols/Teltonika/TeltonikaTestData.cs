using System;
using System.Collections.Generic;
using System.Linq;

namespace Navtrack.Listener.Tests.Protocols.Teltonika
{
    public static class TeltonikaTestData
    {
        private static byte[][] _matrix;
        
        public static byte[][] GetData()
        {
            return _matrix ??= Data.Select(Convert.FromBase64String).ToArray();
        }

        private static readonly List<string> Data = new List<string>
        {
            "DzM1Mjg0ODAyNjQyMTgyMgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==",
            "AAAAAAAALQwBBgAAACUjRk0yPTIyNjEwMjYwMDMxOTg2MiwyMjYxMCwwOS4wMC4wMQ0KAQAAJWAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==",
            "AAAAAAAD3wgTAAABYAZ5ZJ0ADhJ1IBvgbcABZADeCAAOAAcDAQFFAfABArYAC0I4uwLHAAAAAPEAAFhSAAAAAWAGeTxXAA4SfBAb4G8gAWQBEQgAAAAHAwEBRQHwAQK2AAtCOMoCxwAAAADxAAAAAAAAAAFgBnkUVwAOEnwQG+BvIAFgAREIAAAABwMBAUUB8AECtgALQjk2AscAAAAU8QAAAAAAAAABYAZ47FcADhKGMBvgbqABXwEKCAASAAcDAQFFAfABArYAC0I3mwLHAAAAO/EAAAAAAAAAAWAGeMRNAA4SnPAb4G/AAV0BBggADgAHAwEBRQHwAQK2AAtCOLgCxwAAAADxAAAAAAAAAAFgBnibewAOEqRAG+BwYAFdAQMIAAAABwMBAUUB8AECtgALQjk/AscAAAAZ8QAAWFIAAAABYAZ4c1MADhKw0BvgcSABWAEKCAANAAcDAQFFAfABArYAC0I2sALHAAAAFvEAAFhSAAAAAWAGeEsrAA4SvBAb4HGAAVUBAggAAAAHAwEBRQHwAQK2AAtCOXUCxwAAAADxAABYUgAAAAFgBngjAwAOErwQG+BxgAFVAQIIAAAABwMBAUUB8AECtgALQjkEAscAAAAq8QAAWFIAAAABYAZ3+scADhLLIBvgcwABWAEICAAVAAcDAQFFAfABArYAC0I5OALHAAAAPPEAAFhSAAAAAWAGd9KBAA4S7IAb4HNgAV8BCwgAGgAHAwEBRQHwAQK2AAtCON4CxwAAAEPxAABYUgAAAAFgBneqRQAOExAQG+B0IAFkARIIABEABwMBAUUB8AECtgALQjkaAscAAAAp8QAAWFIAAAABYAZ3gkUADhMlkBvgcwABYgEXCAAOAAcDAQFFAfABArYAC0I48QLHAAAAHPEAAFhSAAAAAWAGd1oKAA4TNhAb4HGAAWABFggABwAHAwEBRQHwAQK2AAtCOSgCxwAAACLxAABYUgAAAAFgBncx4QAOE0VQG+BvoAFiARcIAAsABwMBAUUB8AECtgALQjj0AscAAAAZ8QAAWFIAAAABYAZ3CboADhNR4BvgbOABXwEaCAAIAAcDAQFFAfABArYAC0I4vwLHAAAAFfEAAFhSAAAAAWAGduGvAA4TXRAb4GuAAV4BFwgAAAAHAwEBRQHwAQK2AAtCMQYCxwAAAADxAABYUgAAAAFgBna5aQAOE10QG+BrgAFeARcIAAAABwMBAUUB8AECtgALQjkvAscAAAAU8QAAWFIAAAABYAZ2kTcADhNl4BvgagABXgEXCAAHAAcDAQFFAfABArYAC0I4+ALHAAAAFPEAAFhSABMAAEitAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=="
        };
    }
}