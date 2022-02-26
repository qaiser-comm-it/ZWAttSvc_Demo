import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class AttSvcService {
  apiName = 'AttSvc';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/AttSvc/sample' },
      { apiName: this.apiName }
    );
  }
}
