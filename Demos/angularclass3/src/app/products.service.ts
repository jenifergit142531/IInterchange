import { Injectable } from '@angular/core';
import { Product } from './product';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  constructor() { }

  public getProducts()
  {
    let products:Product[];

    products=[
      new Product(100,'iphone',45000),
      new Product(200,'hp mouse',5000),
      new Product(300,'macbookpro',145000)
    ]
    return products;
  }
}
