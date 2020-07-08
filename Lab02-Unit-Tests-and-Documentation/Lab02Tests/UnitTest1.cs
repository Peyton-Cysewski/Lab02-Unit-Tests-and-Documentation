using System;
using Xunit;
using static Lab02_Unit_Tests_and_Documentation.Program;

namespace Lab02Tests
{
    public class UnitTest1
    {
        [Fact]
        public void DoesViewBalanceWork()
        {
            Balance = 10000;

            decimal actual = ViewBalance();

            decimal expected = 10000;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DoesViewBalanceWorkAtZero()
        {
            Balance = 0;

            decimal actual = ViewBalance();

            decimal expected = 0;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DoesWithdrawWork()
        {
            Balance = 10000;
            decimal expected = 7500;

            decimal withdrawalAmount = 2500;
            decimal actual = Withdraw(withdrawalAmount);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DoesWithdrawWorkWithDecimals()
        {
            Balance = 10000;
            decimal expected = 9999.99m;

            decimal withdrawalAmount = 0.01m;
            decimal actual = Withdraw(withdrawalAmount);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IgnoresNegativeWithdrawal()
        {
            Balance = 10000;
            decimal expected = 10000;

            decimal withdrawalAmount = -5000;
            decimal actual = Withdraw(withdrawalAmount);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IgnoresTooLargeWithdrawal()
        {
            Balance = 10000;
            decimal expected = 10000;

            decimal withdrawalAmount = 10001;
            decimal actual = Withdraw(withdrawalAmount);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DoesDepositWork()
        {
            Balance = 10000;
            decimal expected = 15000;

            decimal depositAmount = 5000;
            decimal actual = Deposit(depositAmount);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DoesDepositWorkWithDecimals()
        {
            Balance = 10000;
            decimal expected = 11111.11m;

            decimal depositAmount = 1111.11m;
            decimal actual = Deposit(depositAmount);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void IgnoresNegativeDeposit()
        {
            Balance = 10000;
            decimal expected = 10000;

            decimal depositAmount = -5000;
            decimal actual = Deposit(depositAmount);

            Assert.Equal(expected, actual);
        }
    }
}
