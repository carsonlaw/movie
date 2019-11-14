import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UCenterComponent } from './u-center.component';

describe('UCenterComponent', () => {
  let component: UCenterComponent;
  let fixture: ComponentFixture<UCenterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [UCenterComponent],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UCenterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
