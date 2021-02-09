import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage2Component } from './app-page2.component';

describe('AppPage2Component', () => {
  let component: AppPage2Component;
  let fixture: ComponentFixture<AppPage2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
