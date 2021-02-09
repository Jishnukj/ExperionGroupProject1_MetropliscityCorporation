import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage1ImageComponent } from './app-page1-image.component';

describe('AppPage1ImageComponent', () => {
  let component: AppPage1ImageComponent;
  let fixture: ComponentFixture<AppPage1ImageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage1ImageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage1ImageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
