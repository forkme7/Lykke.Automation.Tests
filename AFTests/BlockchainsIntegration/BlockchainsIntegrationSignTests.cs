﻿using BlockchainsIntegration.LitecoinSign;
using Lykke.Client.AutorestClient.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using XUnitTestCommon.Tests;

namespace AFTests.BlockchainsIntegrationTests.LiteCoin
{
    class BlockchainsIntegrationSignTests
    {
        public class GetLitecoinSignAlive : BlockchainsIntegrationBaseTest
        {
            [Test]
            [Category("Litecoin")]
            [Category("Dash")]
            [Category("Zcash")]
            public void GetLitecoinSignAliveTest()
            {
                var signService = new BlockchainSign();

                var response = signService.GetIsAlive();
                response.Validate.StatusCode(HttpStatusCode.OK);
                Assert.That(response.GetResponseObject().Name, Does.Contain("Sign"));
                Assert.That(response.GetResponseObject().Version, Is.Not.Null);
            }
        }


        public class PostWallet : BlockchainsIntegrationBaseTest
        {
            [Test]
            [Category("Litecoin")]
            [Category("Dash")]
            [Category("Zcash")]
            public void PostWalletTest()
            {
                var signService = new BlockchainSign();

                var response = signService.PostWallet();
                response.Validate.StatusCode(HttpStatusCode.OK);
                Assert.That(response.GetResponseObject().PublicAddress, Is.Not.Empty);
                Assert.That(response.GetResponseObject().PrivateKey, Is.Not.Empty);
            }
        }

        public class PostSign : BlockchainsIntegrationBaseTest
        {
            [Test]
            [Category("Litecoin")]
            [Category("Dash")]
            [Category("Zcash")]
            public void PostSignTest()
            {
                var signService = new BlockchainSign();

                var req = new SignRequest()
                {
                    PrivateKeys = new List<string>() { PKey },
                    TransactionContext = "testHex"
                };

                var response = signService.PostSign(req);
            }
        }
    }
}