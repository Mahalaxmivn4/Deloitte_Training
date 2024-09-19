class Customer
{
    public CustomerId:number = 0;
    public CustomerName:string  = "";
    public Location:string  = "";
 
    constructor(CustomerId:number=0, CustomerName:string = "", Location:string = "")
    {
        this.CustomerId = CustomerId;
        this.CustomerName = CustomerName;
        this.Location = Location;
    }
  

    public showDetails():void
    {
        console.log(`Customer Details :: Id  : ${this.CustomerId}, Name  : ${this.CustomerName}, Location  : ${this.Location}`);
    }
}


let c1:Customer = new Customer();
let c2:Customer = new Customer(10256);
let c3:Customer = new Customer(10256, "Scott");
let c4:Customer = new Customer(10256, "Scott", "Hyd");

c1.showDetails();
c2.showDetails();
c3.showDetails();
c4.showDetails();