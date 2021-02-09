import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage3EditComponent } from './app-page3-edit.component';

describe('AppPage3EditComponent', () => {
  let component: AppPage3EditComponent;
  let fixture: ComponentFixture<AppPage3EditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage3EditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage3EditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
