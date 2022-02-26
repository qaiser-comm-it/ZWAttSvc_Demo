import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { AttSvcComponent } from './components/att-svc.component';
import { AttSvcRoutingModule } from './att-svc-routing.module';

@NgModule({
  declarations: [AttSvcComponent],
  imports: [CoreModule, ThemeSharedModule, AttSvcRoutingModule],
  exports: [AttSvcComponent],
})
export class AttSvcModule {
  static forChild(): ModuleWithProviders<AttSvcModule> {
    return {
      ngModule: AttSvcModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<AttSvcModule> {
    return new LazyModuleFactory(AttSvcModule.forChild());
  }
}
