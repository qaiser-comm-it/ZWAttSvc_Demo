import { TestBed } from '@angular/core/testing';

import { AttSvcService } from './att-svc.service';

describe('AttSvcService', () => {
  let service: AttSvcService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AttSvcService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
