import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage3AddactivityComponent } from './app-page3-addactivity.component';

describe('AppPage3AddactivityComponent', () => {
  let component: AppPage3AddactivityComponent;
  let fixture: ComponentFixture<AppPage3AddactivityComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage3AddactivityComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage3AddactivityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
