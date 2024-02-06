import { TestBed } from '@angular/core/testing';

import { HouseserviceService } from './houseservice.service';

describe('HouseserviceService', () => {
  let service: HouseserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HouseserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
