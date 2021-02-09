import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage1CitizenguidComponent } from './app-page1-citizenguid.component';

describe('AppPage1CitizenguidComponent', () => {
  let component: AppPage1CitizenguidComponent;
  let fixture: ComponentFixture<AppPage1CitizenguidComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage1CitizenguidComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage1CitizenguidComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
