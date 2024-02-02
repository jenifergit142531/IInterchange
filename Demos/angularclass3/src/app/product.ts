
export class Product{
    productId:number;
    name:string;
    price:number;

    constructor(productId:number,name:string,price:number)
    {
        this.productId=productId;
        this.name=name;
        this.price=price;
    }
}