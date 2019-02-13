﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using dom = MLTAscend.Domain.Models;
using dat = MLTAscend.Data.Helpers;

namespace MLTAscend.Tests.UnitTests
{
    public class PredictionHelperTests
    {
        private dom.Prediction sut;
        private dom.User User;
        public dat.PredictionHelper PredictonHelper { get; set; }
        public dat.UserHelper UserHelper { get; set; }

        public PredictionHelperTests()
        {
            User = new dom.User()
            {
                Name = "anon",
                Username = "anonymous",
                Password = "password"
            };

            sut = new dom.Prediction()
            {
                CompanyName = "ryry's chicken and waffles",
                Ticker = "ryry",

            };

            PredictonHelper = new dat.PredictionHelper(new Data.InMemoryDbContext());
            UserHelper = new dat.UserHelper(new Data.InMemoryDbContext());

            UserHelper.SetUser(User);
            PredictonHelper.SetPrediction(sut, User.Username);
        }

        [Fact]
        public void Test_SetPrediction()
        {
            Assert.True(PredictonHelper.SetPrediction(sut, User.Username));
        }

        [Fact]
        public void Test_GetPredictionByTicker()
        {
            var actual = PredictonHelper.GetPredictionByTicker(sut.Ticker);

            Assert.True(actual.Ticker == sut.Ticker);
        }

        [Fact]
        public void Test_GetPredictions()
        {
            var actual = PredictonHelper.GetPredictions();

            Assert.True(actual.Count > 0);
            Assert.True(actual[0].Ticker == sut.Ticker);
        }
    }
}
