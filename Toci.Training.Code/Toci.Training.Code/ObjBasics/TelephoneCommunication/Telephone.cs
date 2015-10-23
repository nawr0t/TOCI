using Toci.Training.Code.ObjBasics.InterfacesExtending;

namespace Toci.Training.Code.ObjBasics.TelephoneCommunication
{
    public class Telephone
    {
        public void Communicate(string telephoneNumber, string message, ITelephoneCommunication communication)
        {
            communication.SendInformation(message);
        } 
    }
}