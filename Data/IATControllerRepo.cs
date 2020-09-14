using System.Collections.Generic;
using bahrain_api.Models;


namespace bahrain_api.Data 
{

    public interface IATControllerRepo
    {

        bool SaveChanges();
        
        IEnumerable<ATController> GetAllControllers();
        ATController GetControllerById(int id);
        IEnumerable<ATController> GetControllerByRating(string rating);
        IEnumerable<ATController> GetSignedOffControllers();
        IEnumerable<ATController> GetSoloValidatedControllers();
        ATController GetControllerByNetworkId(string cid);
        string GetControllerStatus(string cid);
        string GetHomeDivision(string cid);
        //ATController GetControllersByPosition(string positions);
        void AddATController(ATController atc);
        void UpdateATController(ATController atc);
        void DeleteController(ATController atc);


    }

}