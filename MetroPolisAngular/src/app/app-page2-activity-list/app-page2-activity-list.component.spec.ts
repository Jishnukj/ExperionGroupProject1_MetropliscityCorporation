import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage2ActivityListComponent } from './app-page2-activity-list.component';

describe('AppPage2ActivityListComponent', () => {
  let component: AppPage2ActivityListComponent;
  let fixture: ComponentFixture<AppPage2ActivityListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage2ActivityListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage2ActivityListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
