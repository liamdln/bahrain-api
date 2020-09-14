using System.Collections.Generic;
using bahrain_api.Models;

namespace bahrain_api.Data
{
    public interface IStaffRepo
    {
        bool SaveChanges();
        IEnumerable<StaffMember> GetAllStaff();
        StaffMember GetStaffById(int id);
        StaffMember GetStaffByNetworkId(string cid);
        StaffMember GetStaffByCallsign(string callsign);
        
        string GetStaffCallsignByNetworkId(string cid);
        string GetStaffCallsignById(int id);
        int? GetPermissionPowerById(int id);
        int? GetPermissionPowerByCallsign(string callsign);
        string GetEmailById(int id);
        string GetEmailByCallsign(string callsign);
        string GetDepartmentByCallsign(string callsign);
        string GetDepartmentById(int id);
    }
}