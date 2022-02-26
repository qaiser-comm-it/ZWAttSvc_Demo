import { ModuleWithProviders, NgModule } from '@angular/core';
import { ATT_SVC_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class AttSvcConfigModule {
  static forRoot(): ModuleWithProviders<AttSvcConfigModule> {
    return {
      ngModule: AttSvcConfigModule,
      providers: [ATT_SVC_ROUTE_PROVIDERS],
    };
  }
}
