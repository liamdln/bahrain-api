using System.Collections.Generic;
using bahrain_api.Models;


namespace bahrain_api.Data 
{

    public interface IATControllerRepo
    {

        bool SaveChanges();
        
        IEnumerable<ATController> GetAllControllers();
        ATController GetControllerByID(int ID);
        IEnumerable<ATController> GetControllerByRating(string rating);
        IEnumerable<ATController> GetSignedOffControllers();
        IEnumerable<ATController> GetSoloValidatedControllers();
        ATController GetControllerByNetworkID(string networkID);
        ATController GetControllerStatus(int networkID);
        ATController GetHomeDivision(int networkID);
        //ATController GetControllersByPosition(string positions);
        void AddATController(ATController atc);
        void UpdateATController(ATController atc);
        void DeleteController(ATController atc);


    }

}