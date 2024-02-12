import { Component, OnInit } from '@angular/core';
import { Customer } from '../customer';
import { ObjectUnsubscribedError } from 'rxjs';

@Component({
  selector: 'app-parent-customer-list',
  templateUrl: './parent-customer-list.component.html',
  styleUrl: './parent-customer-list.component.css'
})
export class ParentCustomerListComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  customers:Customer[]=[
    {cusNo:100,name:'amy',city:'chennai'},
    {cusNo:200,name:'aron',city:'salem'},
    {cusNo:300,name:'steve',city:'pollachi'}
  ]

  selectedCustomer:Customer=new Customer();

  showDetails(customer:Customer)
  {
    this.selectedCustomer=Object.assign({},customer);
  }

  update(customer:Customer)
  {
    console.log(customer);
    var cust=this.customers.find(e=>e.cusNo==customer.cusNo);
    Object.assign(cust!,customer);
    alert("Customer saved");
  }

}
