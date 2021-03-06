﻿using AssetsData.Fixtures;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using XUnitTestCommon;

namespace AFTests.AssetsTests
{

    [Category("FullRegression")]
    [Category("AssetsService")]
    public partial class AssetsTest : AssetsTestDataFixture
    {
        public AssetsTest()
        {
        }

        #region IsAlive
        [Test]
        [Category("Smoke")]
        [Category("IsAlive")]
        [Category("IsAliveGet")]
        public async Task IsAlive()
        {
            string url = ApiPaths.ISALIVE_BASE_PATH;
            var response = await this.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);
            Assert.True(response.Status == HttpStatusCode.OK);

            Assert.True(response.ResponseJson.Contains("\"Env\":"));
            Assert.True(response.ResponseJson.Contains("\"Version\":"));
        }
        #endregion
    }
}
