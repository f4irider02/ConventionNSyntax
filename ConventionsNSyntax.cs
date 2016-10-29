public class ConventionsNSyntax
{
    private int health = 100;
    private float money;
    public object player;

    public void DealDamage (int damage){
        health -= damage;
        if(health < 0){
            DestroyObject();
        }
    }

    public void DestroyObject(){
        Destroy(player);
    }

    public float CheckBankAccount(float money){
        return money;
    }

    public float Deposit(float myDeposit){
        money += myDeposit 
    }

    public float Withdrawal(float myWithdrawal){
       if(myWithdrawal > money){
            break;
        }
       else{
            money -= myWithdrawal;
        }
    }


    public int health(int amount)
    {
        health -= amount;
        return health;
    }
}

Deposit(1.50);
Withdrawal(4);
