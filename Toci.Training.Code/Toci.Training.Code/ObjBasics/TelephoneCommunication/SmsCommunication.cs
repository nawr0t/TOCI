using Toci.Training.Code.ObjBasics.InterfacesExtending;

namespace Toci.Training.Code.ObjBasics.TelephoneCommunication
{
    public class SmsCommunication : ITelephoneCommunication
    {
        public bool SendInformation(string message)
        {
            return true;
        }
    }
}