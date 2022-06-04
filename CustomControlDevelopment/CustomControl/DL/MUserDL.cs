using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControl.BL;
using System.ComponentModel;

namespace CustomControl.DL
{
    internal class MUserDL
    {
        private static BindingList<MUser> mUsersList = new BindingList<MUser>();

        public static void setIntoMUserList(MUser user)
        {
            mUsersList.Add(user);
        }
        public static BindingList<MUser> getMuserlist()
        {
            return mUsersList;
        }
        public static void clearList()
        {
            mUsersList.Clear();
        }
        public static void deletFromList(MUser user)
        {
            for (int index = 0; index < mUsersList.Count; index++)
            {
                if (mUsersList[index].Username == user.Username && mUsersList[index].Password == user.Password && mUsersList[index].Role == user.Role)
                {
                    mUsersList.RemoveAt(index);
                }
            }
        }
    }
}
