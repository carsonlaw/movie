import { Injectable } from '@angular/core';
import { eLayoutType, addAbpRoutes, ABP } from '@abp/ng.core';
import { addSettingTab } from '@abp/ng.theme.shared';
import { MovieSettingsComponent } from '../components/movie-settings.component';

@Injectable({
  providedIn: 'root',
})
export class MovieConfigService {
  constructor() {
    addAbpRoutes({
      name: 'Movie',
      path: 'movie',
      layout: eLayoutType.application,
      order: 2,
    } as ABP.FullRoute);

    const route = addSettingTab({
      component: MovieSettingsComponent,
      name: 'Movie Settings',
      order: 1,
      requiredPolicy: '',
    });
  }
}
