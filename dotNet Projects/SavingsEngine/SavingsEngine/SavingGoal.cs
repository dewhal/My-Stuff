using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavingsEngine
{
    internal class SavingGoal
    {
        private DateTime targetDate;
        private double targetAmount;
        private double totalToDate;
        private short priority;
        private string name;

        public SavingGoal(string name, double savingsTarget, DateTime dateToSaveFor, short priority)
        {
            this.name = name;
            this.targetDate = dateToSaveFor;
            this.targetAmount = savingsTarget;
            this.priority = priority;
        }

        public SavingGoal(string name, double savingsTarget, DateTime dateToSaveFor, short priority, double totalToDate)
            : this(name, savingsTarget, dateToSaveFor, priority)
        {
            this.totalToDate = totalToDate;
        }

        public string Name
        {
            get { return this.name; }
        }

        public DateTime TargetDate
        {
            get { return this.targetDate; }
        }

        public double TargetAmount
        {
            get { return this.targetAmount; }
        }

        public double SavingsToDate
        {
            get { return this.totalToDate; }
        }

        public short Priority
        {
            get { return this.priority; }
        }

        public bool GoalAchieved
        { 
            get { return (this.totalToDate >= this.targetAmount);
        }
    }
}
