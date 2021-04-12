/* 
 * Tradovate API
 *
 * Tradovate API provides an access to the complete set of robust Tradovate functionality.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Tradovate.Services.Client;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate.Services.Test
{
    /// <summary>
    ///  Class for testing PositionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PositionsApiTests
    {
        private PositionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PositionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PositionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PositionsApi
            //Assert.IsInstanceOfType(typeof(PositionsApi), instance, "instance is a PositionsApi");
        }

        /// <summary>
        /// Test FindPosition
        /// </summary>
        [Test]
        public void FindPositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.FindPosition(name);
            //Assert.IsInstanceOf<Position> (response, "response is Position");
        }
        /// <summary>
        /// Test GetAllFillPairs
        /// </summary>
        [Test]
        public void GetAllFillPairsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllFillPairs();
            //Assert.IsInstanceOf<List<FillPair>> (response, "response is List<FillPair>");
        }
        /// <summary>
        /// Test GetAllPositions
        /// </summary>
        [Test]
        public void GetAllPositionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllPositions();
            //Assert.IsInstanceOf<List<Position>> (response, "response is List<Position>");
        }
        /// <summary>
        /// Test GetFillPair
        /// </summary>
        [Test]
        public void GetFillPairTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetFillPair(id);
            //Assert.IsInstanceOf<FillPair> (response, "response is FillPair");
        }
        /// <summary>
        /// Test GetFillPairs
        /// </summary>
        [Test]
        public void GetFillPairsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetFillPairs(ids);
            //Assert.IsInstanceOf<List<FillPair>> (response, "response is List<FillPair>");
        }
        /// <summary>
        /// Test GetOwnedFillPairs
        /// </summary>
        [Test]
        public void GetOwnedFillPairsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedFillPairs(masterid);
            //Assert.IsInstanceOf<List<FillPair>> (response, "response is List<FillPair>");
        }
        /// <summary>
        /// Test GetOwnedFillPairsBatch
        /// </summary>
        [Test]
        public void GetOwnedFillPairsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedFillPairsBatch(masterids);
            //Assert.IsInstanceOf<List<FillPair>> (response, "response is List<FillPair>");
        }
        /// <summary>
        /// Test GetOwnedPositions
        /// </summary>
        [Test]
        public void GetOwnedPositionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedPositions(masterid);
            //Assert.IsInstanceOf<List<Position>> (response, "response is List<Position>");
        }
        /// <summary>
        /// Test GetOwnedPositionsBatch
        /// </summary>
        [Test]
        public void GetOwnedPositionsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedPositionsBatch(masterids);
            //Assert.IsInstanceOf<List<Position>> (response, "response is List<Position>");
        }
        /// <summary>
        /// Test GetPosition
        /// </summary>
        [Test]
        public void GetPositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetPosition(id);
            //Assert.IsInstanceOf<Position> (response, "response is Position");
        }
        /// <summary>
        /// Test GetPositions
        /// </summary>
        [Test]
        public void GetPositionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetPositions(ids);
            //Assert.IsInstanceOf<List<Position>> (response, "response is List<Position>");
        }
    }

}