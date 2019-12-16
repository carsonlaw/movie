import { NgModule } from '@angular/core';
import { MovieComponent } from './components/movie.component';
import { MovieRoutingModule } from './movie-routing.module';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CoreModule } from '@abp/ng.core';

@NgModule({
  declarations: [MovieComponent],
  imports: [CoreModule, ThemeSharedModule, MovieRoutingModule],
  exports: [MovieComponent],
})
export class MovieModule {}
