import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPageNavComponent } from './app-page-nav.component';

describe('AppPageNavComponent', () => {
  let component: AppPageNavComponent;
  let fixture: ComponentFixture<AppPageNavComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPageNavComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPageNavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
