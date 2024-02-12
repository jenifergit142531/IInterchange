import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParentCustomerListComponent } from './parent-customer-list.component';

describe('ParentCustomerListComponent', () => {
  let component: ParentCustomerListComponent;
  let fixture: ComponentFixture<ParentCustomerListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ParentCustomerListComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ParentCustomerListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
