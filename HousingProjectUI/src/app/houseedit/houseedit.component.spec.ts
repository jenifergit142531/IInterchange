import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HouseeditComponent } from './houseedit.component';

describe('HouseeditComponent', () => {
  let component: HouseeditComponent;
  let fixture: ComponentFixture<HouseeditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HouseeditComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HouseeditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
