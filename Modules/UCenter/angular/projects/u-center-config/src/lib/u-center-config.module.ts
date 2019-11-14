import { NgModule, APP_INITIALIZER } from '@angular/core';
import { UCenterConfigService } from './services/u-center-config.service';
import { noop } from '@abp/ng.core';
import { UCenterSettingsComponent } from './components/u-center-settings.component';

@NgModule({
  declarations: [UCenterSettingsComponent],
  providers: [{ provide: APP_INITIALIZER, deps: [UCenterConfigService], multi: true, useFactory: noop }],
  exports: [UCenterSettingsComponent],
  entryComponents: [UCenterSettingsComponent],
})
export class UCenterConfigModule {}
