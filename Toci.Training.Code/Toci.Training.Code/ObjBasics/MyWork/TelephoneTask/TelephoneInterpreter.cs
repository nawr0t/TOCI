﻿using System.Diagnostics;
using Toci.Training.Code.ObjBasics.InterfacesExtending;
using Toci.Training.Code.ObjBasics.TelephoneCommunication;

namespace Toci.Training.Code.ObjBasics.TelephoneTask
{
    public abstract class TelephoneInterpreter
    {
        private int tosieniedziedziczy;

        public void GetUserChoice(int chosenOption)
        {
            ITelephoneCommunication communication = ChooseMedium(chosenOption);

            tosieniedziedziczy = 8;

            Telephone phone = new Telephone();

            phone.Communicate("570751507", "czesc", communication);

            Debug.WriteLine("{0} has created {1} for {2}", MyNick(), communication.GetType(), chosenOption);
            //communication.SendInformation()
        }

        protected abstract ITelephoneCommunication ChooseMedium(int chosenOption); //dla 1 - photo, 2 - sms, 3 - voice

        protected abstract string MyNick();
    }
}