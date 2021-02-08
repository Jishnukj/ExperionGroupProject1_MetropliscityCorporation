import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage1Component } from './app-page1.component';

describe('AppPage1Component', () => {
  let component: AppPage1Component;
  let fixture: ComponentFixture<AppPage1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
