import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HousecreateComponent } from './housecreate.component';

describe('HousecreateComponent', () => {
  let component: HousecreateComponent;
  let fixture: ComponentFixture<HousecreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HousecreateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HousecreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
