using System;
using System.Collections.Generic;
using System.Linq;
using bahrain_api.Models;

namespace bahrain_api.Data
{

    public class SqlATControllerRepo : IATControllerRepo
    {
        private readonly ATControllerContext context;

        public SqlATControllerRepo(ATControllerContext context)
        {
            this.context = context;
        }

        public void AddATController(ATController atc)
        {
            if (atc == null)
            {
                throw new ArgumentNullException(nameof(atc));
            }

            this.context.ATControllers.Add(atc);

        }

        public void DeleteController(ATController atc)
        {
            if (atc == null) 
            {
                throw new ArgumentNullException(nameof(atc));
            }
            this.context.ATControllers.Remove(atc);
        }

        public IEnumerable<ATController> GetAllControllers()
        {
            return this.context.ATControllers.ToList();
        }

        public ATController GetControllerByID(int ID)
        {
            return this.context.ATControllers.FirstOrDefault(atc => atc.id == ID);
        }

        public ATController GetControllerByNetworkID(string networkID)
        {
            return this.context.ATControllers.FirstOrDefault(atc => atc.networkID == networkID);
        }

        public IEnumerable<ATController> GetControllerByRating(string rating)
        {
            return this.context.ATControllers.Where(atc => atc.rating == rating).ToList();
        }

        public ATController GetControllerStatus(int networkID)
        {
            throw new NotImplementedException();
        }

        public ATController GetHomeDivision(int networkID)
        {
            throw new NotImplementedException();
        }

        //TODO: Fix this: Problem: can't use commas in the browser, maybe find something different to put inbetween.
        // public IEnumerable<ATController> GetControllersByPosition(string positions)
        // {
        //     return this.context.ATControllers(atc => atc.approvedPositions == positions);
        // }

        public IEnumerable<ATController> GetSignedOffControllers()
        {
            return this.context.ATControllers.Where(atc => atc.hasSignOff == true).ToList();
        }

        public IEnumerable<ATController> GetSoloValidatedControllers()
        {
            return this.context.ATControllers.Where(atc => atc.onSolo == true).ToList();
        }

        public bool SaveChanges()
        {
            return (this.context.SaveChanges() >= 0);
        }

        // PUT
        public void UpdateATController(ATController atc)
        {
            // Nothing needs to be done... yet
        }
    }

}