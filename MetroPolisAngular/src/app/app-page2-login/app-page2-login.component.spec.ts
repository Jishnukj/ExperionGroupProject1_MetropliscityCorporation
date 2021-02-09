import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage2LoginComponent } from './app-page2-login.component';

describe('AppPage2LoginComponent', () => {
  let component: AppPage2LoginComponent;
  let fixture: ComponentFixture<AppPage2LoginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage2LoginComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage2LoginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
