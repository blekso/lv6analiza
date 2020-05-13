using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        private DateTime CreationTime;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
            this.CreationTime = DateTime.Now;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }
        public Memento StoreState()
        {
            return new Memento(this.ownerName, this.ownerAddress, this.balance, this.CreationTime);
        }
        public void RestoreState(Memento previous)
        {
            this.ownerName = previous.ownerName;
            this.ownerAddress = previous.ownerAddress;
            this.balance = previous.balance;
            this.CreationTime = previous.CreationTime;
        }
    }
}
