﻿using NModbus.Data;
using NModbus.Message;
using Xunit;

namespace NModbus.UnitTests.Message
{
    public class ReturnQueryDataRequestResponseFixture
    {
        [Fact]
        public void ReturnQueryDataRequestResponse()
        {
            RegisterCollection data = new RegisterCollection(1, 2, 3, 4);
            DiagnosticsRequestResponse request = new DiagnosticsRequestResponse(ModbusFunctionCodes.DiagnosticsReturnQueryData, 5,
                data);
            Assert.Equal(ModbusFunctionCodes.Diagnostics, request.FunctionCode);
            Assert.Equal(ModbusFunctionCodes.DiagnosticsReturnQueryData, request.SubFunctionCode);
            Assert.Equal(5, request.SlaveAddress);
            Assert.Equal(data.NetworkBytes, request.Data.NetworkBytes);
        }

        [Fact]
        public void ProtocolDataUnit()
        {
            RegisterCollection data = new RegisterCollection(1, 2, 3, 4);
            DiagnosticsRequestResponse request = new DiagnosticsRequestResponse(ModbusFunctionCodes.DiagnosticsReturnQueryData, 5,
                data);
            Assert.Equal(new byte[] { 8, 0, 0, 0, 1, 0, 2, 0, 3, 0, 4 }, request.ProtocolDataUnit);
        }
    }
}