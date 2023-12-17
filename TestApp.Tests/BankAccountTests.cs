using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double balance = 10.00;
        BankAccount bankAccount = new BankAccount(balance);

        // Act

        // Assert
        Assert.That(bankAccount.Balance, Is.EqualTo(10.00));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double balance = 0.00;
        double depositAmount = 50.00;
        BankAccount bankAccount = new BankAccount(balance);

        // Act
        bankAccount.Deposit(depositAmount);

        // Assert
        Assert.That(bankAccount.Balance, Is.EqualTo(50.00));
    }

    private void _balance()
    {
        throw new NotImplementedException();
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double balance = 10.00;
        double depositAmount = -50.00;
        BankAccount bankAccount = new BankAccount(balance);

        // Act & Assert
        Assert.That(() => bankAccount.Deposit(depositAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double balance = 100.00;
        double withdrawAmount = 50.00;
        BankAccount bankAccount = new BankAccount(balance);

        // Act
        bankAccount.Withdraw(withdrawAmount);

        // Assert
        Assert.That(bankAccount.Balance, Is.EqualTo(50.00));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double balance = 10.00;
        double withdrawAmount = -50.00;
        BankAccount bankAccount = new BankAccount(balance);

        // Act & Assert
        Assert.That(() => bankAccount.Withdraw(withdrawAmount), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double balance = 10.00;
        double withdrawAmount = 50.00;
        BankAccount bankAccount = new BankAccount(balance);

        // Act & Assert
        Assert.That(() => bankAccount.Withdraw(withdrawAmount), Throws.ArgumentException);
    }
}
