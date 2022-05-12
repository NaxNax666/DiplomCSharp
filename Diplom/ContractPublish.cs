using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom
{
    class ContractPublish
    {
        private float buffBill;
        private float deposit = 200;
        private Copyrighter copyrighter;
        private User user;
        ContractPublish(Copyrighter cp, User ur, string title)
        {
            this.copyrighter = cp;
            this.user = ur;
            Publication pub = copyrighter.GetPublicationByTitle(title);
            if (pub!=null){
                ur.AddPublication(pub);
                if((pub.Cost+deposit) <= user.bill)
                {
                    user.bill -= (pub.Cost + deposit);
                    buffBill = deposit;
                    copyrighter.bill += pub.Cost;
                }
                else
                {
                    //TODO ошибка не хватает средств
                }
                
            }
            else
            {
                //TODO ошибка нет публикации
            }


        }

        public void ContractSucsses()
        {
            user.bill += deposit;

        }

        public void ContractFailed()
        {
            copyrighter.bill += deposit;
        }
    }
}
