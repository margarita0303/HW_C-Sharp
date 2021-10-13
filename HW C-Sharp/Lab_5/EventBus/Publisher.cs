using System;
using System.Collections.Generic;

namespace EventBus
{
    delegate void BankAccountChangedEventHandler(Object sender, EventArgs eventArgs);

    class BankAccountPublisher
    {
        public event BankAccountChangedEventHandler BankAccountChanged;
        private int _dollars;

        public void Put(int dollars)
        {
            _dollars = +dollars;
            OnBankAccountChanged();
        }

        public void Withdraw(int dollars)
        {
            if (_dollars >= dollars)
            {
                _dollars -= dollars;
                OnBankAccountChanged();
            }
        }

        protected virtual void OnBankAccountChanged()
        {
            BankAccountChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}