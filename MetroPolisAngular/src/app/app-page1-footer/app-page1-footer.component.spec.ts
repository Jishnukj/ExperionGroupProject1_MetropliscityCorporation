import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppPage1FooterComponent } from './app-page1-footer.component';

describe('AppPage1FooterComponent', () => {
  let component: AppPage1FooterComponent;
  let fixture: ComponentFixture<AppPage1FooterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AppPage1FooterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AppPage1FooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
