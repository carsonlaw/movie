import { NgModule, APP_INITIALIZER } from '@angular/core';
import { MovieConfigService } from './services/movie-config.service';
import { noop } from '@abp/ng.core';
import { MovieSettingsComponent } from './components/movie-settings.component';

@NgModule({
  declarations: [MovieSettingsComponent],
  providers: [{ provide: APP_INITIALIZER, deps: [MovieConfigService], multi: true, useFactory: noop }],
  exports: [MovieSettingsComponent],
  entryComponents: [MovieSettingsComponent],
})
export class MovieConfigModule {}
