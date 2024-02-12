import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildCustomerDetailsComponent } from './child-customer-details.component';

describe('ChildCustomerDetailsComponent', () => {
  let component: ChildCustomerDetailsComponent;
  let fixture: ComponentFixture<ChildCustomerDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ChildCustomerDetailsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ChildCustomerDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
