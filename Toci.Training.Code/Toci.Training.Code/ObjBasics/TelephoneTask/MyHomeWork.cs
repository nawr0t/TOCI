using Toci.Training.Code.ObjBasics.InterfacesExtending;
using Toci.Training.Code.ObjBasics.TelephoneCommunication;

namespace Toci.Training.Code.ObjBasics.TelephoneTask
{
    public class MyHomeWork : TelephoneInterpreter
    {
        protected override ITelephoneCommunication ChooseMedium(int chosenOption)
        {
            if (chosenOption == 1)
            {
                SmsCommunication smsCommunication = new SmsCommunication();
                return smsCommunication;
            }
            if (chosenOption == 2)
            {
                VoiceCommunication voiceCommunication = new VoiceCommunication();
                return voiceCommunication;
            }
            if (chosenOption == 3)
            {
                PhotoCommunication photoCommunication = new PhotoCommunication();
                return photoCommunication;
            }
            else return null;
        }

        protected override string MyNick()
        {
            return "Nawro";
        }
    }
}