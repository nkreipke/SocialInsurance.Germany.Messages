﻿using System;
using System.Collections.Generic;
using System.IO;

using SocialInsurance.Germany.Messages.Pocos;

using Xunit;

namespace SocialInsurance.Germany.Messages.Tests.Deuev
{
    public class TestDEUEVVerfahren : TestBasis
    {
        [Fact]
        public void TestDEUEVMeldung10()
        {
            var input = LoadData("deuev10.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "10");
                Assert.NotNull(dsme.DBNA);
                Assert.NotNull(dsme.DBAN);
                Assert.NotNull(dsme.DBME);
                Assert.Null(dsme.DBUV);
                Assert.Null(dsme.DBKS);
                Assert.Null(dsme.DBSO);
                Assert.Null(dsme.DBSV);
                if (string.IsNullOrWhiteSpace(dsme.VSNR))
                {
                    Assert.NotNull(dsme.DBGB);
                    Assert.NotNull(dsme.DBEU);
                }

                writer.Write(dsme);
                streamObject = reader.Read();
                var ncsz = Assert.IsType<NCSZ>(streamObject);
                writer.Write(ncsz);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung11()
        {
            var input = LoadData("deuev11.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "11");
                Assert.NotNull(dsme.DBME);
                Assert.NotNull(dsme.DBNA);
                Assert.Null(dsme.DBGB);
                Assert.NotNull(dsme.DBAN);
                Assert.Null(dsme.DBEU);
                Assert.Null(dsme.DBUV);
                Assert.Null(dsme.DBKS);
                Assert.Null(dsme.DBSO);
                Assert.Null(dsme.DBSV);
                writer.Write(dsme);
                streamObject = reader.Read();
                var ncsz = Assert.IsType<NCSZ>(streamObject);
                writer.Write(ncsz);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung12()
        {
            var input = LoadData("deuev12.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "12");
                writer.Write(dsme);
                streamObject = reader.Read();
                var ncsz = Assert.IsType<NCSZ>(streamObject);
                writer.Write(ncsz);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }

        [Fact]
        public void TestDEUEVMeldung20()
        {
            var input = LoadData("deuev20.dat").ReadToEnd();
            var output = new StringWriter();
            var writer = StreamFactory.CreateWriter("deuev", output);
            var reader = StreamFactory.CreateReader("deuev", new StringReader(input));
            try
            {
                var streamObject = reader.Read();
                var vosz = Assert.IsType<VOSZ>(streamObject);
                writer.Write(vosz);
                streamObject = reader.Read();
                var dsko = Assert.IsType<DSKO>(streamObject);
                writer.Write(dsko);
                streamObject = reader.Read();
                var dsme = Assert.IsType<DSME>(streamObject);
                Assert.Equal(dsme.GD, "20");
                Assert.NotNull(dsme.DBNA);
                Assert.NotNull(dsme.DBSO);
                Assert.Null(dsme.DBUV);
                Assert.Null(dsme.DBKS);
                Assert.Null(dsme.DBSV);
                if (string.IsNullOrWhiteSpace(dsme.VSNR))
                {
                    Assert.NotNull(dsme.DBGB);
                    Assert.NotNull(dsme.DBAN);
                    Assert.NotNull(dsme.DBEU);
                }

                writer.Write(dsme);
                streamObject = reader.Read();
                var ncsz = Assert.IsType<NCSZ>(streamObject);
                writer.Write(ncsz);
                writer.Close();
                Assert.Equal(input, output.ToString());
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
