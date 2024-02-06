import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HouselistComponent } from './houselist.component';

describe('HouselistComponent', () => {
  let component: HouselistComponent;
  let fixture: ComponentFixture<HouselistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HouselistComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HouselistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
