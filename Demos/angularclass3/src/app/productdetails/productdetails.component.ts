import { Component } from '@angular/core';
import { ProductsService } from '../products.service';
import { Product } from '../product';

@Component({
  selector: 'app-productdetails',
  templateUrl: './productdetails.component.html',
  styleUrl: './productdetails.component.css'
})
export class ProductdetailsComponent {

  pro!:Product[];
  constructor(private productservice:ProductsService){}

 /*productservice;
  constructor()
  {
    this.productservice=new ProductsService();
  }*/
  
  getProduct()
  {
    this.pro=this.productservice.getProducts();
  }


}
