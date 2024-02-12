import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Customer } from '../customer';

@Component({
  selector: 'app-child-customer-details',
  templateUrl: './child-customer-details.component.html',
  styleUrl: './child-customer-details.component.css'
})
export class ChildCustomerDetailsComponent implements OnInit {


  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  @Input() customer:Customer=new Customer();

  @Output() customerChange:EventEmitter<Customer>=new EventEmitter<Customer>();
    

  update()
  {
    this.customerChange.emit(this.customer);
  }
  

}
