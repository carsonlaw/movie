import { NgModule } from '@angular/core';
import { UCenterComponent } from './components/u-center.component';
import { UCenterRoutingModule } from './u-center-routing.module';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@NgModule({
  declarations: [UCenterComponent],
  imports: [CoreModule, ThemeSharedModule, UCenterRoutingModule],
  exports: [UCenterComponent],
})
export class UCenterModule {}
