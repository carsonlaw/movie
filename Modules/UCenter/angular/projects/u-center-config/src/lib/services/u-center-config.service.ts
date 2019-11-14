import { Injectable } from '@angular/core';
import { eLayoutType, addAbpRoutes, ABP } from '@abp/ng.core';
import { addSettingTab } from '@abp/ng.theme.shared';
import { UCenterSettingsComponent } from '../components/u-center-settings.component';

@Injectable({
  providedIn: 'root',
})
export class UCenterConfigService {
  constructor() {
    addAbpRoutes({
      name: 'UCenter',
      path: 'u-center',
      layout: eLayoutType.application,
      order: 2,
    } as ABP.FullRoute);

    const route = addSettingTab({
      component: UCenterSettingsComponent,
      name: 'UCenter Settings',
      order: 1,
      requiredPolicy: '',
    });
  }
}
