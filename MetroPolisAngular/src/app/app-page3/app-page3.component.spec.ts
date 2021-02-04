import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage3Component } from './app-page3.component';

describe('AppPage3Component', () => {
  let component: AppPage3Component;
  let fixture: ComponentFixture<AppPage3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage3Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
