import { TestBed } from '@angular/core/testing';

import { ReasonsServiceService } from './reasons-service.service';

describe('ReasonsServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ReasonsServiceService = TestBed.get(ReasonsServiceService);
    expect(service).toBeTruthy();
  });
});
