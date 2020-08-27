using System.Collections.Generic;
using bahrain_api.Models;

namespace bahrain_api.Data
{

    public class MockATControllerRepo : IATControllerRepo
    {
        public void AddATController(ATController atc)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteController(ATController atc)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ATController> GetAllControllers()
        {
            var controllers = new List<ATController>
            {
                new ATController{id=0, fullName="Piam Lee", rating="I1", email="user1@email.com"},
                new ATController{id=1, fullName="Vavin", rating="C3", email="user2@email.com"},
                new ATController{id=2, fullName="Kornie", rating="I3", email="user3@email.com"}
            };

            return controllers;
        }

        public ATController GetControllerByID(int ID)
        {
            return new ATController{id=0, fullName="Piam Lee", rating="I1", email="user1@email.com"};
        }

        public ATController GetControllerByNetworkID(string networkID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ATController> GetControllerByRating(string rating)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ATController> GetControllersByPosition(string positions)
        {
            throw new System.NotImplementedException();
        }

        public ATController GetControllerStatus(int networkID)
        {
            throw new System.NotImplementedException();
        }

        public ATController GetHomeDivision(int networkID)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ATController> GetSignedOffControllers()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ATController> GetSoloValidatedControllers()
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateATController(ATController atc)
        {
            throw new System.NotImplementedException();
        }
    }

}