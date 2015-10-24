﻿namespace Toci.Training.Code.ObjBasics.TelephoneTask.TasksTrainingTwo
{
    public abstract class GhostRiderStringManipulationsBase
    {
        //true: beata; at, ata, ta, ea
        //false: beata; ae, eb, aa
        protected abstract bool IsStringInString(string subject, string seek);

        //true: beata; aat, taae
        //false: beata, aaa, taaa, tta, aee
        protected abstract bool IsStringElementsInString(string subject, string seek);

        //true: beata; ataeb, tbaea
        //false: beata; aaateb, fdwgdw
        protected abstract bool IsStringAnagramOfString(string subject, string seek);

        public abstract StringManipulationsResults RunStringOperations(string subject, string seek);

        protected abstract string GetNick();

        protected virtual StringManipulationsResults Run(string subject, string seek)
        {
            var result = new StringManipulationsResults();

            result.Nick = GetNick();
            result.Subject = subject;
            result.Seek = seek;

            result.Type = this.GetType();

            result.IsAnagram = IsStringAnagramOfString(subject, seek);
            result.IsStringElementsInString = IsStringElementsInString(subject, seek);
            result.IsStringInString = IsStringInString(subject, seek);

            return result;
        }
    }
}