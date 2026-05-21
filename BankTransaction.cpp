#include <stdio.h>
#include <string.h>

struct Bank {
    long bank_id;
    float balance;
    char secured_pass[10];
};

void Deposit (Bank *account, int amount) {
    account->balance += amount;
}

bool Withdraw (Bank *account, int amount, char password) {
    if (strcmp(account->secured_pass, password)) {
        account->balance -= amount;
        return true;
    }
        else {
            printf(" wrong password \n");
            return false;
        }
}
int main () {
    Bank account;
    account.balance = 0;
    strcpy(account.secured_pass, "secure");
    account.bank_id = 123412341234;
    Deposit(&account, 100.0);

    printf("%f\n", account.balance);
}
